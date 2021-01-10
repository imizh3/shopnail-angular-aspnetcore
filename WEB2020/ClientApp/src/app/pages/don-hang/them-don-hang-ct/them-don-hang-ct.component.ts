import { DataSourceService } from './../../../services/data.service';
import { OrderService } from './../../../@core/mock/order.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NbWindowRef, NbToastrService, NbGlobalPhysicalPosition } from '@nebular/theme';
import { Giaodich } from '../../../@core/data/giaodich';

@Component({
  selector: 'ngx-them-don-hang-ct',
  templateUrl: './them-don-hang-ct.component.html',
  styleUrls: ['./them-don-hang-ct.component.scss']
})
export class ThemDonHangCtComponent implements OnInit {
  form: FormGroup;
  giaoDich: Giaodich;
  constructor(private fb: FormBuilder, private winRef: NbWindowRef, private orderService: OrderService, private toastService: NbToastrService, private data: DataSourceService) { }

  ngOnInit(): void {

    this.form = this.fb.group({
      tenSPControl: ['', Validators.required],
      soluongControl: ['', Validators.required],
      donGiaControl: [{ value: 'đơn giá', disabled: true }, Validators.required],
    });
    this.data.currentGiaoDich.subscribe((d) => (this.giaoDich = d));
  }

  onSubmit() {
    this.winRef.close();
    this.addItemToOrder();
  }
  addItemToOrder() {
    const soluong = this.form.value.soluongControl;
    if (soluong <= 0) {
      // alert('số lượng đặt hàng không hợp lệ!');
      this.toastService.show('số lượng đặt hàng không hợp lệ!', 'Không thêm được sản phẩm!', {
        position: NbGlobalPhysicalPosition.BOTTOM_RIGHT,
        status: 'warning',
      });
      return;
    }
    const giaodichct = {
      ...this.form.value.tenSPControl,
      magiaodichpk: this.giaoDich.magiaodichpk,
      soluong: soluong,
    };

    const newGiaoDich = this.orderService.addOrderDetail(giaodichct, this.giaoDich);
    this.data.changeGiaoDich(newGiaoDich);

  }

  addItemKmToOrder() {
    const soluong = this.form.value.soluongControl;
    if (soluong <= 0) {
      // alert('số lượng đặt hàng không hợp lệ!');
      this.toastService.show('số lượng đặt hàng không hợp lệ!', 'Không thêm được sản phẩm!', {
        position: NbGlobalPhysicalPosition.BOTTOM_RIGHT,
        status: 'warning',
      });
      return;
    }
    const giaodichct = {
      ...this.form.value.tenSPControl,
      magiaodichpk: this.giaoDich.magiaodichpk,
      iskhuyenmai: true,
      soluong: soluong,
    };
    const newGiaoDich = this.orderService.addOrderDetail(giaodichct, this.giaoDich);
    this.data.changeGiaoDich(newGiaoDich);

    this.winRef.close();

  }

  onChangeSanPham(value) {
    if (value) {
      this.form.patchValue({ donGiaControl: value.giabanbuonchuavat });
      this.form.patchValue({ soluongControl: 1 });
    }
  }

}

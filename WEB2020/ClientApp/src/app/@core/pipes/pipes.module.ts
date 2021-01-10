import { ThungLePipePipe } from './thung-le-pipe.pipe';
import { NgModule } from '@angular/core';
import { CommonModule } from "@angular/common";



@NgModule({
  declarations: [ThungLePipePipe], // <---
  imports: [CommonModule],
  exports: [ThungLePipePipe], // <---
})

export class PipeModule { }

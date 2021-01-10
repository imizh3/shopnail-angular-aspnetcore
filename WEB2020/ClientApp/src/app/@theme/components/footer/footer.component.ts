import { Component } from "@angular/core";

@Component({
  selector: "ngx-footer",
  styleUrls: ["./footer.component.scss"],
  template: `
    <div class="socials">
      <a
        href="http://dataviet.vn"
        target="_blank"
        class="ion ion-social-github"
      ></a>
      <a
        href="http://dataviet.vn"
        target="_blank"
        class="ion ion-social-facebook"
      ></a>
      <a
        href="http://dataviet.vn"
        target="_blank"
        class="ion ion-social-twitter"
      ></a>
      <a
        href="http://dataviet.vn"
        target="_blank"
        class="ion ion-social-linkedin"
      ></a>
    </div>
  `,
})
export class FooterComponent {}

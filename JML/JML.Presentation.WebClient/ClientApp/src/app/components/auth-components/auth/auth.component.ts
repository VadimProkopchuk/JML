import { Component, OnInit } from '@angular/core';
import {FormControl, FormGroup, Validators} from '@angular/forms';
import {Router} from '@angular/router';
import {CurrentUserService} from '../../../shared/services/current-user.service';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.component.html',
  styleUrls: ['./auth.component.css']
})
export class AuthComponent implements OnInit {
  form: FormGroup;
  submitted = false;
  message: string;

  constructor(private currentUserService: CurrentUserService,
              private router: Router) {
  }

  ngOnInit() {
    this.form = new FormGroup({
      Email: new FormControl(null, [Validators.email, Validators.required]),
      Password: new FormControl(null, [Validators.required])
    });
  }

  onSubmit(formData) {
    this.submitted = true;
    this.currentUserService.login(formData.Email, formData.Password)
      .subscribe(() => {
        this.form.reset();
        // this.router.navigate(['/admin', 'dashboard']);
        this.submitted = false;
      }, () => {
        this.submitted = false;
      });
  }
}

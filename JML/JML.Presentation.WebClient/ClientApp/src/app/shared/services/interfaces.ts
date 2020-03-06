import {Role} from '../models/role';

export interface TokenPair {
  token: string;
  expiredAt: Date;
}

export interface LoginModel {
  Email: string;
  Password: string;
}

export interface User {
  id: string;
  firstName: string;
  lastName: string;
  groupName: string;
  roles: Array<UserRole>;
}

export interface UserRole {
  display: string;
  value: Role;
}

export interface Lecture {
  id?: string;
  name: string;
  url: string;
  content: string;
  preview?: string;
  tags: Array<Tag>;
  createdAt?: Date;
  modifiedAt?: Date;
}

export interface Tag {
  display: String;
  value?: String;
}

export interface VerificationUser {
  firstName: string;
  lastName: string;
  email: string;
}

export interface CreateUser extends VerificationUser {
  password: string;
  verificationCode: string;
}

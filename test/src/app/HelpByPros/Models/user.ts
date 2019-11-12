import UserCreate from './user-create';

export default interface Users extends UserCreate {
    FirstName:string;
    LastName:string;
    Username:string;
    Password:string;
    phone:string;
    IsProfessional:true;
    Category:string;
    yearOfExp:string;
    Credential: string;
    Summary:string;
  }
  
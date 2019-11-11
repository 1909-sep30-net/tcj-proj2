import UserCreate from './user-create';

export default interface Users extends UserCreate {
    Summary:string;
    yearOfExp:string;
    IsProfessional:true;
    epertise: string;
    first: string ;
    username: string;
  }
  
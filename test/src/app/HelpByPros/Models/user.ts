import UserCreate from './UserCreate';

export default interface Professional extends UserCreate {
    Summary:string;
    yearOfExp:string;
    IsProfessional:true;
    epertise: string;
  }
  
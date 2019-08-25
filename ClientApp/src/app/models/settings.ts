export class Settings {
  static readonly apiUrl: string = "http://localhost:29164";
  static readonly level: any = { "Owner": 1, "Group": 2, "SubGroup": 3, "Agency": 4 };
  static readonly loginStatus: any = { "LoggedIn": 1, "LoggedOut": 2, "OnBreak": 3 };
  static readonly isMockEnable: boolean = true;
}
export const environment = {
  production: true
};


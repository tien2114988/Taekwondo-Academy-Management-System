import {NgModule} from '@angular/core';
import {AppSharedModule} from '@app/shared/app-shared.module';
import {PersonalInfoRoutingModule} from './personal-info-routing.module';
import {PersonalInfoComponent} from './personal-info.component';
import { StudentServiceProxy } from '@shared/service-proxies/service-proxies';

@NgModule({
    declarations: [PersonalInfoComponent],
    imports: [AppSharedModule, PersonalInfoRoutingModule],
    providers:[StudentServiceProxy]
})
export class PersonalInfoModule {}

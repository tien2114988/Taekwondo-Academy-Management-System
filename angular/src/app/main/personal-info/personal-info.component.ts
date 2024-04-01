import { Component, Injector, OnInit } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { StudentServiceProxy, StudentListDto, ListResultDtoOfStudentListDto } from '@shared/service-proxies/service-proxies';

@Component({
    templateUrl: './personal-info.component.html',
    styleUrls: ['./personal-info.component.css'],
    animations: [appModuleAnimation()]
})
export class PersonalInfoComponent extends AppComponentBase implements OnInit {

    students: StudentListDto[] = [];
    filter: string = '2114988';

    constructor(
        injector: Injector,
        private _studentService: StudentServiceProxy
    ) {
        super(injector);
    }

    ngOnInit(): void {
        this.getStudents();
    }

    getStudents(): void {
        this._studentService.getStudents(this.filter).subscribe((result) => {
            this.students = result.items;
        });
    }
}

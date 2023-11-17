import {
  Component,
  EventEmitter,
  Input,
  OnChanges,
  Output,
  SimpleChanges,
} from '@angular/core';
import {
  FormBuilder,
  FormGroup,
  Validators,
  AbstractControl,
} from '@angular/forms';
import { EntradaPost } from '../../../../core/models/entradaPost.model';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-agregar-component',
  templateUrl: './agregar.component.html',
  styleUrl: './agregar.component.css',
})
export class AgregarComponent implements OnChanges {
  currentDate;
  entradaForm: FormGroup;
  @Output() agregarEntrada: EventEmitter<EntradaPost> =
    new EventEmitter<EntradaPost>();
  @Input() limpiarFormulario?: number;

  constructor(
    private formBuilder: FormBuilder,
    private spinner: NgxSpinnerService,
    private toastr: ToastrService
  ) {
    this.currentDate = new Date();
    this.entradaForm = this.formBuilder.group({
      titulo: ['', [Validators.required, this.requiredValidator]],
      autor: ['', [Validators.required, this.requiredValidator]],
      fechaPublicacion: [
        '',
        [Validators.required, this.dateValidator, this.requiredValidator],
      ],
      contenido: ['', [Validators.required, this.requiredValidator]],
    });
  }

  ngOnChanges(changes: SimpleChanges) {
    if (this.limpiarFormulario != null) {
      this.entradaForm.reset();
      this.spinner.hide();
      this.toastr.success('Entrada agregada correctamente.', 'Correcto');
    }
  }

  onSubmit() {
    if (this.entradaForm.valid) {
      console.log('Formulario válido 😀', this.entradaForm.value);
      this.spinner.show();
      this.agregarEntrada.emit(this.entradaForm.value);
    } else {
      console.log('Formulario inválido 😕');
    }
  }

  dateValidator(control: AbstractControl): { [key: string]: boolean } | null {
    const selectedDate = new Date(control.value);
    const currentDate = new Date();

    if (selectedDate > currentDate) {
      return { futureDate: true };
    }
    return null;
  }

  requiredValidator(
    control: AbstractControl
  ): { [key: string]: boolean } | null {
    const selectedControl = control.value;
    if (selectedControl == '') {
      return { emptyField: true };
    }
    return null;
  }
}

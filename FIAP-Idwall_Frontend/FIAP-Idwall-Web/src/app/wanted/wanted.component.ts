import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-wanted',
  templateUrl: './wanted.component.html',
  styleUrls: ['./wanted.component.scss'],
})
export class WantedComponent implements OnInit {
  public wantedList: any = [];
  public procuradosFiltrados: any = [];

  mostrarImagem: boolean = true;
  private _filtroLista: string = '';

  public get filtroLista() {
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.procuradosFiltrados = this.filtroLista
      ? this.filtrarProcurados(this.filtroLista)
      : this.wantedList;
  }

  filtrarProcurados(filtrarPor: string): any {
    filtrarPor = filtrarPor.toLocaleLowerCase();

    return this.wantedList.filter(
      (wanted: any) =>
        wanted.fullname.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
        wanted.nationality.toLocaleLowerCase().indexOf(filtrarPor) !== -1
      // wanted.organizacao?.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );
  }

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getWanted();
  }

  alterarImagem() {
    this.mostrarImagem = !this.mostrarImagem;
  }

  public getWanted(): void {
    this.http.get('https://localhost:5001/api/FiapIdwall').subscribe(
      (response) => {
        this.wantedList = response;
        this.procuradosFiltrados = this.wantedList;
      },
      (error) => console.log(error)
    );
  }
}

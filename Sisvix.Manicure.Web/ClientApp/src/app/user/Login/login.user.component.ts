import { Component, OnInit } from "@angular/core"
import { Usuario } from "../../model/usuario";
import { Router, ActivatedRoute } from "@angular/router";
import { UserService } from "../../services/user/user.servico";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent implements OnInit {
  public usuario: Usuario;
  public returnUrl: string;
  public mensagem: string;
  private ativar_spinner: boolean;
  public _usuarioAutenticado = this.userServices._usuarioAutenticado;
  public _UrlNovoUsuario = this.userServices.baseURL + "novo-usuario";

  constructor(private router: Router, private activatedRouter: ActivatedRoute, private userServices: UserService) {

  }
  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }

  entrar() {
    this.ativar_spinner = true;
    this.userServices.verificarUsuario(this.usuario).subscribe(
      usuario_json => {

        this.userServices.usuario = usuario_json;

        if (this.returnUrl == null) {
          //this.router.navigate(['/app-home']);
          sessionStorage.setItem("usuarioLogado", "true");
          window.location.href = this.userServices.baseURL + "app-home";
        }
        else {
          sessionStorage.setItem("usuarioLogado", "true");
          window.location.href = this.returnUrl;
          //this.router.navigate([this.returnUrl]);
        }
      },
      err => {
        this.mensagem = err.error;
        this.ativar_spinner = false;
      }
    );
  }


}

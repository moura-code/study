<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Calendario</title>
    <link href="../assets/css/login.css" rel="stylesheet">
  </head>
  <body>
    <main>
      <div class="box">
        <div class="inner-box">
          <div class="forms-wrap">
            <form action="../Backend/ingreso.php" method="post" autocomplete="off" class="sign-in-form">
              <div class="logo">
                <img src="../assets/img/logo.png" alt="easyclass" />
                <h4>Calendario</h4>
              </div>

              <div class="heading">
                <h2>Bienvenido a Calendario</h2>
                <h6>¿No tienes Cuenta?</h6>
                <a href="#" class="toggle">Registrarte</a>
              </div>

              <div class="actual-form">
                <div class="input-wrap">
                  <input
                    type="text"
                    minlength="4"
                    class="input-field"
                    autocomplete="off"
                    name="usuario"
                    required
                  />
                  <label>Usuario</label>
                </div>

                <div class="input-wrap">
                  <input
                    type="password"
                    minlength="4"
                    class="input-field"
                    autocomplete="off"
                    name="contra"
                    required
                  />
                  <label>Contraseña</label>
                </div>

                <input type="submit" value="Ingresar" class="sign-btn" />

                <p class="text">
                  ¿Olvidaste tu contraseña?
                 ¿Necesitas <a href="#"> ayuda?</a> para ingresar
                </p>
              </div>
            </form>

            <form action="../Backend/registro.php" method="post" autocomplete="off" class="sign-up-form">
              <div class="logo">
                <img src="../assets/img/logo.png" alt="easyclass" />
                <h4></h4>
              </div>

              <div class="heading">
                <h2>Registrate ahora</h2>
                <h6>¿Ya tienes una cuenta?</h6>
                <a href="#" class="toggle">Inicia Sesión</a>
              </div>

              <div class="actual-form">
                <div class="input-wrap">
                  <input
                    type="text"
                    minlength="4"
                    name="nombre"
                    class="input-field"
                    autocomplete="off"
                    required
                  />
                  <label>Nombre</label>
                </div>
                <div class="input-wrap">
                  <input
                    type="text"
                    minlength="4"
                    name="usuario"
                    class="input-field"
                    autocomplete="off"
                    required
                  />
                  <label>Usuario</label>
                </div>

                <div class="input-wrap">
                  <input
                    type="email"
                    class="input-field"
                    autocomplete="off"
                    name="correo"
                    required
                  />
                  <label>Correo</label>
                </div>

                <div class="input-wrap">
                  <input
                    type="password"
                    minlength="4"
                    class="input-field"
                    autocomplete="off"
                    name="contra"
                    required
                  />
                  <label>Contraseña</label>
                </div>

                <input type="submit" value="Sign Up" class="sign-btn" />

                <p class="text">
                  antes de ingresar lea los
                  <a href="#">Terminos</a> y la
                  <a href="#">politica de privacidad</a>
                </p>
              </div>
            </form>
          </div>

          <div class="carousel">
            <div class="images-wrapper">
              <img src="../assets/img/image1.png" class="image img-1 show" alt="" />
              <img src="../assets/img/image2.png" class="image img-2" alt="" />
              <img src="../assets/img/image3.png" class="image img-3" alt="" />
            </div>

            <div class="text-slider">
              <div class="text-wrap">
                <div class="text-group">
                  <h2>Calendariza eventos</h2>
                  <h2>Todo para empresas</h2>
                  <h2>Para equipos de todo el mundo</h2>
                </div>
              </div>

              <div class="bullets">
                <span class="active" data-value="1"></span>
                <span data-value="2"></span>
                <span data-value="3"></span>
              </div>
            </div>
          </div>
        </div>
      </div>
    </main>

    <!-- Javascript file -->
    <script src="../assets/js/app.js"></script>
  </body>
</html>

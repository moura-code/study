import { useState } from "react";
import logo from "../../images/logo.jpeg";
import style from "./style.module.css";
const Login = () => {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");

  return (
    <>
      <div className={style.main}>
        <img src={logo} alt="Logo" className={style.logo} />
        <h1>Sistema bibliotecario UTSV</h1>
      </div>
      <div>
        <p>Usuario:</p>
        <input type='text' />

        <p>Passoword:</p>
        <input type="password" />
      </div>
    </>
  );
};

export default Login;

import { useState } from "react";
import Button from "react-bootstrap/esm/Button";
import style from "./style.module.css";
import axios from "axios";
import { useNavigate } from "react-router-dom";
const Login = ({ setIsLoggedIn }: any) => {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [errrorMessage, setErrorMessage] = useState("");
  let navigate = useNavigate();
  const [regis, setregis] = useState(true);
  const fetchlogin = async () => {
    if (regis) {
      try {
        const data = await axios.post("http://localhost:3000/auth/singup", {
          user: username,
          password: password,
        });
        localStorage.setItem("token", data.data.token);
        setIsLoggedIn(true);
        navigate("/inicio");
      } catch (err: any) {
        setErrorMessage(err.response.data.message);
      }
    } else {
      try {
        const data = await axios.post("http://localhost:3000/auth/singin", {
          user: username,
          password: password,
        });
        localStorage.setItem("token", data.data.token);
        setIsLoggedIn(true);
        navigate("/inicio");
      } catch (err: any) {
        setErrorMessage(err.response.data.message);
      }
    }
  };
  return (
    <>
      <div className={style.form} >
        {regis ? <h1>Login:</h1> : <h1>Registro:</h1>}
        <div>
          {errrorMessage ? (
            <h1 style={{ color: "red" }}>{errrorMessage}</h1>
          ) : (
            <></>
          )}
          <h2>Usuario:</h2>
          <input
            type="text"
            autoComplete="username"
            value={username}
            onChange={(e) => setUsername(e.target.value)}
          />

          <h2>Passoword:</h2>
          <input
            autoComplete="current-password"
            type="password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
          />
        </div>
        <Button
          type="submit"
          className={style.button}
          variant="primary"
          onClick={fetchlogin}
          disabled={!password || !username}
        >
          ingresar
        </Button>
        {regis ? (
          <Button
            className={style.button}
            variant="secundary"
            onClick={() => {
              setregis(false);
            }}
          >
            Registro
          </Button>
        ) : (
          <Button
            type="submit"
            className={style.button}
            variant="secundary"
            onClick={() => {
              setregis(true);
            }}
          >
            Login
          </Button>
        )}
      </div>
    </>
  );
};

export default Login;

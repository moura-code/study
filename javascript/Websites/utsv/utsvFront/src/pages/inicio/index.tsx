import { useEffect, useState } from "react";
import Button from "react-bootstrap/esm/Button";
import style from "./style.module.css";
import person from "../../images/persons.jpeg";
import { buttons } from "../../Data/main";


import { Link, useNavigate } from "react-router-dom";
const Inicio = ({ loged }: { loged: boolean }, { setIsLoggedIn }: any) => {
  let navigate = useNavigate();
  useEffect(() => {
    if (!loged) {
      navigate("/");
    }
  }, [loged]);
  const cerrar = () => {
    console.log(11);
    localStorage.removeItem("token");
    navigate("/");
  };

  return (

    <div className={style.content}>
      <div className={style.buttonslayout}>
        {buttons.map((c, key) => {
          return (
            <li className={style.liButton} key={key}>
              <Link to={c.title.toLowerCase()} className={style.link}>
                <Button>
                  <p>{c.title}</p>
                </Button>
              </Link>
            </li>
          );
        })}
        <li className={style.liButton}>
          <Button onClick={cerrar}>
            <h6>CERRAR SESION</h6>
          </Button>
        </li>
      </div>
      <img src={person} />
    </div>
  );
};

export default Inicio;

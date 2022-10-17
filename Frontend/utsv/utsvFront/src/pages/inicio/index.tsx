import { useState } from "react";
import Button from "react-bootstrap/esm/Button";
import style from "./style.module.css";
import person from "../../images/persons.jpeg";
import { Link } from "react-router-dom";
const Inicio = () => {
  const buttons = [
    { title: "CATALAGO" },
    { title: "RESERVAR" },
    { title: "CONSULTA" },
    { title: "CERRAR SESION" },
  ];
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
      </div>
      <img src={person} />
    </div>
  );
};

export default Inicio;

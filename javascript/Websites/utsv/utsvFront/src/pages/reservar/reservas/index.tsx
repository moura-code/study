import axios from "axios";
import { useEffect, useState } from "react";
import { Container } from "react-bootstrap";
import { useNavigate, useParams } from "react-router-dom";
import style from "./style.module.css";
const Reservas = ({ loged }: { loged: boolean }) => {
  let navigate = useNavigate();
  const [books, setbooks] = useState<any[]>([]);
  const [loading, setloading] = useState(false);
  const getbooks = async () => {
    const data = await axios.get("http://localhost:3000/books/reserva", {
      headers: {
        Authorization: "Bearer " + localStorage.getItem("token"),
      },
    });
    setbooks(data.data);
  };
  useEffect(() => {
    if (!loged) {
      navigate("/");
    }

    getbooks();
    setloading(true);
  }, [loged]);

  if (!books) {
    return null;
  } else
    return (
      <Container>
        {books.map((book) => {
          return (
            <div className={style.book}>
              <h2>Nombre: {book.nombre}</h2>
              <h4>Codigo del libro:{book.codigo_libro}</h4>
              <h4>Carrera: {book.carrera}</h4>
              <h4>Modalidad: {book.modalidad}</h4>
              <h4>Matricula:   {book.matricula}</h4>
            </div>
          );
        })}
      </Container>
    );
};

export default Reservas;

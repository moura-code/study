import axios from "axios";
import { useEffect, useState } from "react";
import { Container } from "react-bootstrap";
import { useNavigate, useParams } from "react-router-dom";
import style from "./style.module.css";
const Books = ({ loged }: { loged: boolean }) => {
  let { type } = useParams();
  let navigate = useNavigate();
  const [books, setbooks] = useState<any[]>([]);
  const [loading, setloading] = useState(false);
  const getbooks = async () => {
    const data = await axios.get("http://localhost:3000/books/type/" + type, {
      headers: {
        Authorization: "Bearer " + localStorage.getItem("token"),
      },
    });
    setbooks(data.data);
    console.log(data.data);
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
              <h2>Titulo: {book.titulo}</h2>
              <h4>Autor:{book.autor}</h4>
              <h4>Libro de: {book.type}</h4>
            </div>
          );
        })}
      </Container>
    );
};

export default Books;

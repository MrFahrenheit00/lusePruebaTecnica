const express = require('express');
const bodyParser = require('body-parser');

const app = express();
const port = 2023; 

app.use(bodyParser.urlencoded({ extended: false }));

let nota = ''; //La variable nota, empieza vacia

//Ruta para el guardado de la nota
app.post('/guardar-nota', (req, res) => {
  nota = req.body.nota;
  res.sendStatus(200);
  console.log(`Nota guardada.`);
});

//Ruta para recibir la nota
app.get('/leer-nota', (req, res) => {
  res.send(nota);
  console.log(`Leer nota.`);
});

//Ruta para borrar la nota almacenada
app.delete('/borrar-nota', (req, res) => {
  nota = '';
  res.sendStatus(200);
  console.log(`Nota borrada.`);
});
// Inicia el servidor
app.listen(port, () => {
  console.log(`Servicio iniciado en el puerto: ${port}`);
});
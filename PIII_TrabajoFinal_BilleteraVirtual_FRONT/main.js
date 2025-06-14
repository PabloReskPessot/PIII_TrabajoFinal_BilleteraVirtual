
function IrAVista(pagina)
{
window.location.href = pagina;
}

function llamarAPI ()
{
  fetch("http://localhost:5017/api/ppp")
    .then(res => res.json()) // Si devuelve JSON
    .then(data => console.log("Respuesta del GET:", data))
    .catch(err => console.error("Error en el GET:", err));
}

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

function llamarAPIget() {
    fetch("http://localhost:5017/api/ppp")
    .then(response => response.json())
    .then(data => {
        console.log("Datos recibidos:", data);
    })
    .catch(error => {
        console.error("Error al llamar a la API:", error);
    });
}

function header ()
{
    fetch("Header.html").then(response => response.text()).then(data => {
        document.getElementById("header-container").innerHTML = data;
      });
}

async function exchange(coin, fiat, volumen,operacion){
    const res = await fetch(`https://criptoya.com/api/binance/${coin}/${fiat}/${volumen}`);
    const data = await res.json();

    if (operacion === "compra")
    {
        console.log(data.ask)
        return data.ask;
    };
    if (operacion === "venta")
    {
        console.log(data.bid)
        return data.bid;
    };
    //.then(data => {console.log("contacto", data)})
}

  async function cotcriptoya() {
    const coins = ["BTC", "ETH", "USDT"];
    const fiat = "ARS";
    const volumen = 0.01;
    const operaciones = ["compra", "venta"];
    const ids = ["btccompra", "btcventa", "ethcompra", "ethventa", "usdtcompra", "usdtventa"];

    let index = 0;

    for (let i = 0; i < coins.length; i++) {
        for (let j = 0; j < operaciones.length; j++) {
            const precio = await exchange(coins[i], fiat, volumen, operaciones[j]);

            const contenedor = document.getElementById(ids[index]);
            if (contenedor) {
                contenedor.innerHTML = ""; // limpiar por si ya tenía algo
                const div = document.createElement("div");
                div.innerText = `$ ${precio.toLocaleString("es-AR")}`;
                contenedor.appendChild(div);
            }

            index++;
        }
    }
}

async function cuentas() {
    fetch()
    
}


window.onload = function() {
  cotcriptoya();
};

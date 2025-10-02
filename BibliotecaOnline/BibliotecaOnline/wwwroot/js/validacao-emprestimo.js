document.addEventListener("DOMContentLoaded", function () {
    const formEmprestimo = document.querySelector("form");
    if (!formEmprestimo) return;

    formEmprestimo.addEventListener("submit", function (event) {
        const hoje = new Date();
        hoje.setHours(0, 0, 0, 0);

        const inputDataRetirada = document.getElementById("DataRetirada");
        if (inputDataRetirada) {
            const dataRetirada = new Date(inputDataRetirada.value);
            dataRetirada.setHours(0, 0, 0, 0);
            if (dataRetirada > hoje) {
                alert("A data de retirada não pode ser superior a data de hoje.");
                inputDataRetirada.focus();
                event.preventDefault();
                return;
            }
        }

        const inputDataEntrega = document.getElementById("DataEntrega");
        if (inputDataEntrega) {
            const dataEntrega = new Date(inputDataEntrega.value);
            dataEntrega.setHours(0, 0, 0, 0);
            if (inputDataRetirada) {
                const dataRetirada = new Date(inputDataRetirada.value);
                dataRetirada.setHours(0, 0, 0, 0);

                if (dataEntrega < dataRetirada) {
                    alert("Data de entrega não pode ser anterior à data de retirada.");
                    inputDataEntrega.focus();
                    event.preventDefault();
                    return;
                }
            }
        }
    });
});
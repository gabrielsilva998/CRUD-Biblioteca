document.addEventListener("DOMContentLoaded", function () {
    const camposData = document.querySelectorAll("input[type='date']");

    camposData.forEach(function (campo) {
        campo.addEventListener("change", function () {
            const dataSelecionada = new Date(campo.value);
            const hoje = new Date();
            hoje.setHours(0, 0, 0, 0);

            if (dataSelecionada > hoje) {
                alert("A data não pode ser futura.");
                campo.value = "";
            }
        });
    });
});
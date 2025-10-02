document.addEventListener("DOMContentLoaded", function () {
    const formAluno = document.querySelector("form");
    if (!formAluno) return;

    formAluno.addEventListener("submit", function (event) {
        const inputDataNascimento = document.getElementById("DataNascimento");
        if (!inputDataNascimento) return;

        const hoje = new Date();
        hoje.setHours(0, 0, 0, 0);

        const dataNascimento = new Date(inputDataNascimento.value);
        dataNascimento.setHours(0, 0, 0, 0);

        if (dataNascimento > hoje) {
            alert("Informe uma data de nascimento válida.");
            inputDataNascimento.focus();
            event.preventDefault();
        }
    });
});
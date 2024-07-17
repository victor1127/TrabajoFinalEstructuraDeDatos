let previousId = null;

function MostrarDescripcion(jsonTarea, tdId) {
    const tarea = JSON.parse(jsonTarea);

    if (previousId !== null) {
        let item = document.getElementById(`table-tr-${previousId}`);
        if (item) { item.style.backgroundColor = ""; }
    }

    document.getElementById(`table-tr-${tdId}`).style.backgroundColor = "#CAF4FF";
    previousId = tdId;


    var createdDate = new Date(tarea.FechaInicio);
    var expDate = new Date(tarea.FechaFinal);
    var options = { year: 'numeric', month: 'short', day: 'numeric' };
    var formattedCreatedDate = createdDate.toLocaleDateString('en-US', options);
    var formattedExpDate = expDate.toLocaleDateString('en-US', options);

    document.getElementById("task-created-date").innerText = formattedCreatedDate;
    document.getElementById("task-exp-date").innerText = formattedExpDate;
    document.getElementById("task-description-details").innerText = tarea.Descripcion;
    let historyText = document.getElementById("history-content");
    let htmlContent = "";
    const stack = tarea.Actualizacion;

    for (const item of stack) {
        var updatedDate = new Date(item.FechaCambio);
        var formatedDate = updatedDate.toLocaleDateString('en-US', options);

        htmlContent += `<p id="task-history-date">${formatedDate}: Tarea <span id="task-history-detail">${item.EstadoEntidad}</span></p>`;
    }

    historyText.innerHTML = htmlContent;
}

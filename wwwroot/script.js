async function carregarEquipamentos() {
    const response = await fetch("/api/equipamentos");
    const equipamentos = await response.json();

    const tbody = document.getElementById("tabelaEquipamentos");
    const valorTotal = document.getElementById("totalValor");

    let soma = 0;
    const tipos = {};

    equipamentos.forEach(eq => {
        let valor = 0;
        switch (eq.tipo.toLowerCase()) {
            case "cardio": valor = 5000; break;
            case "musculação": valor = 3000; break;
            case "funcional": valor = 1000; break;
            case "equilíbrio": valor = 800; break;
            default: valor = 1500;
        }

        soma += valor;
        tipos[eq.tipo] = (tipos[eq.tipo] || 0) + 1;

        const linha = `
            <tr>
                <td>${eq.nome}</td>
                <td>${eq.tipo}</td>
                <td>${eq.marca}</td>
                <td>${eq.modelo}</td>
                <td>${eq.status}</td>
                <td>${new Date(eq.dataAquisicao).toLocaleDateString()}</td>
                <td>R$ ${valor.toFixed(2)}</td>
            </tr>
        `;
        tbody.innerHTML += linha;
    });

    valorTotal.textContent = `R$ ${soma.toLocaleString('pt-BR', { minimumFractionDigits: 2 })}`;
    gerarGrafico(tipos);
}

function gerarGrafico(tipos) {
    const ctx = document.getElementById("graficoTipos").getContext("2d");
    new Chart(ctx, {
        type: "pie",
        data: {
            labels: Object.keys(tipos),
            datasets: [{
                label: "Distribuição por Tipo",
                data: Object.values(tipos),
                backgroundColor: ["#6f42c1", "#0d6efd", "#20c997", "#ffc107", "#dc3545"]
            }]
        }
    });
}

carregarEquipamentos();

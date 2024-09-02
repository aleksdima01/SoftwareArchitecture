let tableData = [
    {
        "className": "Воркаут",
        "time": "10:30",
        "maxPeople": 20,
        "currentPeople": 4
    },
    {
        "className": "Бокс",
        "time": "19:30",
        "maxPeople": 8,
        "currentPeople": 0
    },
    {
        "className": "Cycle",
        "time": "18:30",
        "maxPeople": 24,
        "currentPeople": 12
    },
    {
        "className": "Плавание",
        "time": "13:40",
        "maxPeople": 12,
        "currentPeople": 12
    }
]

const tableBody = document.querySelector('tbody');
if (localStorage.getItem('classes') !== null) {
    tableBody.innerHTML = localStorage.getItem('classes');
}
else {
    tableData.forEach((element, index) => {
        tableBody.insertAdjacentHTML('beforeend', ` <tr>
        <th scope="row">${index + 1}</th>
        <td>${element.className}</td>
        <td>${element.time}</td>
        <td class="maxPeople">${element.maxPeople}</td>
        <td class="addPeople">${element.currentPeople} </td>
        <td><button type="button" class="btn btn-success btn-sm entry">Записаться</button></td>
        <td><button type="button" class="btn btn-danger btn-sm cancel">Отменить запись</button></td>
    </tr>`);
    });
}

const entryButton = document.querySelectorAll('.entry');
const cancelButton = document.querySelectorAll('.cancel');
entryButton.forEach(button => {
    const remBtn = button.parentElement.nextElementSibling.firstChild;
    if (Number(button.parentNode.parentNode.querySelector('.addPeople').textContent) === 0) {
        remBtn.classList.add("disabled");
    }
    button.addEventListener('click', (e) => {
        currentPeople = Number(e.target.parentNode.parentNode.querySelector('.addPeople').textContent);
        const maxPeople = Number(e.target.parentNode.parentNode.querySelector('.maxPeople').textContent);

        if (currentPeople < maxPeople) {
            if (currentPeople === maxPeople - 1) {
                e.target.parentNode.parentNode.querySelector('.addPeople').textContent = currentPeople + 1;
                button.classList.add("disabled")
            }
            else {
                e.target.parentNode.parentNode.querySelector('.addPeople').textContent = currentPeople + 1;
            }
            localStorage.setItem('classes', tableBody.innerHTML)
        }
        if (currentPeople === 0) {
            remBtn.classList.remove("disabled")
            localStorage.setItem('classes', tableBody.innerHTML)
        }
    })

})
cancelButton.forEach(button => {
    const maxPeople = Number(button.parentNode.parentNode.querySelector('.maxPeople').textContent);
    const addBtn = button.parentElement.previousElementSibling.firstChild;

    if (Number(button.parentNode.parentNode.querySelector('.addPeople').textContent) === maxPeople) {
        addBtn.classList.add("disabled");
    }
    button.addEventListener('click', (e) => {
        let currentPeople = Number(e.target.parentNode.parentNode.querySelector('.addPeople').textContent);
        if (currentPeople < maxPeople && currentPeople > 1) {
            e.target.parentNode.parentNode.querySelector('.addPeople').textContent = currentPeople - 1;
            localStorage.setItem('classes', tableBody.innerHTML)
        }
        else if (currentPeople === maxPeople) {
            e.target.parentNode.parentNode.querySelector('.addPeople').textContent = currentPeople - 1;
            addBtn.classList.remove("disabled")
            localStorage.setItem('classes', tableBody.innerHTML)
        }
        else if (currentPeople === 1) {
            e.target.parentNode.parentNode.querySelector('.addPeople').textContent = currentPeople - 1;
            button.classList.add("disabled")
            localStorage.setItem('classes', tableBody.innerHTML)
        }
    })
})

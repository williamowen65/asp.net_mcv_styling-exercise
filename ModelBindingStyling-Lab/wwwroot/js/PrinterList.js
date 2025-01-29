document.addEventListener('DOMContentLoaded', () => {

    // update the breadcrumb
    Array.from(document.querySelectorAll('.breadcrumb-item'))
        .forEach(el => {
            el.classList.remove('active', 'disabled-link')
        })
    document.querySelector('#printer-list-breadcrumb').classList.remove('d-none')
    document.querySelector('#printer-list-breadcrumb').classList.add('active', 'disabled-link')


    // Set listener for child-table-toggle
    Array.from(document.querySelectorAll('.child-table-toggle'))
        .forEach(el => {

            el.addEventListener('click', toggleChildTable)
        })

})


function toggleChildTable(e) {
    // find parent row
    const parentRow = e.target.closest('tr').nextElementSibling
    parentRow.classList.toggle('d-none')
}
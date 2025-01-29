document.addEventListener('DOMContentLoaded', () => {

    // update the breadcrumb
    Array.from(document.querySelectorAll('.breadcrumb-item'))
        .forEach(el => {
            el.classList.remove('active', 'disabled-link')
        })
    document.querySelector('#user-profile-breadcrumb').classList.remove('d-none')
    document.querySelector('#user-profile-breadcrumb').classList.add('active', 'disabled-link')


})
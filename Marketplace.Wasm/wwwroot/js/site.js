﻿window.openModal = (modalId) => {
    var modal = new bootstrap.Modal(document.getElementById(modalId));
    modal.show();
};

window.closeModal = (modalId) => {
    var modal = new bootstrap.Modal(document.getElementById(modalId));
    modal.hide();
};

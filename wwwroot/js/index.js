const $loginFormToggle = $("#loginToggle");
const $loginForm = $(".loginForm");

$loginForm.hide();

$loginFormToggle.on("change", () => {
    $loginForm.toggle();
})
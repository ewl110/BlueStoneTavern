const CREATE_CHARACTER_FORM = document.getElementById("createCharacterForm");

function goToNextFieldset(evt) {
    const FIELDSETS = CREATE_CHARACTER_FORM.querySelectorAll("fieldset");
    const PARENT_FIELDSET = evt.target.closest("fieldset");
    const NEXT_FIELDSET = PARENT_FIELDSET.nextElementSibling;

    FIELDSETS.forEach((fieldset) => fieldset.classList.remove("isSelected"));

    if (NEXT_FIELDSET) {
        NEXT_FIELDSET.classList.remove("isDisabled");
        NEXT_FIELDSET.classList.add("isSelected");
    }
}

function selectFieldset(evt) {
    const FIELDSETS = CREATE_CHARACTER_FORM.querySelectorAll("fieldset");
    const LEGEND = evt.target;

    cossole.log(LEGEND.closest("fieldset"));

    if (!LEGEND.parentNode.classList.contains("isDisabled")) {
        FIELDSETS.forEach((fieldset) => fieldset.classList.remove("isSelected"));
        evt.target.closest("fieldset").classList.add("isSelected");
    }
}

if (CREATE_CHARACTER_FORM) {
    const LEGENDS = CREATE_CHARACTER_FORM.querySelectorAll('legend');
    const RADIO_INPUTS = CREATE_CHARACTER_FORM.querySelectorAll('input');//input[type="radio"]
    console.log(LEGENDS);
    LEGENDS.forEach((legend) => legend.addEventListener("ciick", selectFieldset));
    RADIO_INPUTS.forEach((input) => input.addEventListener("change", goToNextFieldset));
}
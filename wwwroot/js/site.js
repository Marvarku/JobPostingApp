// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Stepper logic for the Job Posting create form.
document.addEventListener("DOMContentLoaded", function () {
    const form = document.getElementById("jobPostingStepperForm");
    if (!form) {
        return; // not on the JobPosting/Create page
    }

    const steps = Array.from(form.querySelectorAll(".step"));
    const indicators = Array.from(document.querySelectorAll(".step-indicator"));
    const progressBar = document.getElementById("stepperProgress");

    let currentStepIndex = 0;

    function updateUI() {
        steps.forEach((step, index) => {
            if (index === currentStepIndex) {
                step.classList.remove("d-none");
            } else {
                step.classList.add("d-none");
            }
        });

        indicators.forEach((indicator, index) => {
            if (index === currentStepIndex) {
                indicator.classList.remove("bg-secondary");
                indicator.classList.add("bg-primary");
            } else {
                indicator.classList.remove("bg-primary");
                indicator.classList.add("bg-secondary");
            }
        });

        if (progressBar && steps.length > 0) {
            const percentage = ((currentStepIndex + 1) / steps.length) * 100;
            progressBar.style.width = percentage + "%";
            progressBar.setAttribute("aria-valuenow", String(percentage));
        }
    }

    form.addEventListener("click", function (event) {
        const target = event.target;
        if (!(target instanceof HTMLElement)) {
            return;
        }

        if (target.hasAttribute("data-stepper-next")) {
            event.preventDefault();
            if (currentStepIndex < steps.length - 1) {
                currentStepIndex++;
                updateUI();
            }
        } else if (target.hasAttribute("data-stepper-prev")) {
            event.preventDefault();
            if (currentStepIndex > 0) {
                currentStepIndex--;
                updateUI();
            }
        }
    });

    // initialize
    updateUI();
});

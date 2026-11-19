import { auth } from "./firebase.js";
import {
    createUserWithEmailAndPassword,
    signOut
} from "https://www.gstatic.com/firebasejs/9.6.10/firebase-auth.js";

const registerForm = document.getElementById("signup-form");
const messageDiv = document.getElementById("message");
const submitButton = registerForm.querySelector("button[type='submit']");

registerForm.addEventListener("submit", async function (event) {
    event.preventDefault();

    const email = document.getElementById("Email").value.trim();
    const password = document.getElementById("Password").value;
    const confirmPassword = document.getElementById("ConfirmPassword").value;

    messageDiv.textContent = "";

    if (password !== confirmPassword) {
        messageDiv.textContent = "Passwords do not match.";
        return;
    }

    submitButton.disabled = true;

    try {
        await createUserWithEmailAndPassword(auth, email, password);
    } catch (error) {
        messageDiv.textContent = error.message;
        submitButton.disabled = false;
        return;
    }

    try {
        await signOut(auth);
        window.location.href = "/Account/Login";
    } catch {
        messageDiv.textContent = "Account created, but automatic sign-out failed.";
    }
});

submitButton.disabled = false;
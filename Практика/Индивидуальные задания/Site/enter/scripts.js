
document.getElementById("check").onclick=function()
{
    let login=document.getElementById("login").value;
    let pass1=document.getElementById("password").value;
    if(login=="admin" && pass1=="admin")
    {
        alert("Welcome");
        window.open("index.html");
        window.close();
    }
    else alert("Неправильный логин или пароль");
}


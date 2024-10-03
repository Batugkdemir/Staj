function login(){
    const username=document.getElementById('username').value;
    const password=document.getElementById('password').value;

    const validUsername = '';
    const validPassword = ''

    document.getElementById('error-message').styledisplay = 'none';

    if (username === validUsername && password === validPassword) {
        alert ('Giriş Başarılı')
        window.location.href = '../index.html';
    }
    else { alert('Hatalı Giriş');document.getElementById('error-message').styledisplay = 'block';}
}
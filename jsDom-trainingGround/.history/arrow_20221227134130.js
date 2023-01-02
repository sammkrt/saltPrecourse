var k_username ="guest";
var k_password = "12345";
var flag = true;


while(flag = true){
    var username = prompt("Lutfen Kullanici Adinizi Girin:");
    var password = prompt("Lutfen sifrenizi girin:");
    if (username === k_username && password === k_password) {
        console.log("Giris yapildi")
        flag = false;
        break
    }
    else{
        console.log("Lutfen tekrar deneyiniz")
        flag = false;
    }
}
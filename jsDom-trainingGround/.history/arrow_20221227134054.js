var k_username ="guest";
var k_password = "12345";
var flag = false;

var username = prompt("Lutfen Kullanici Adinizi Girin:");
var password = prompt("Lutfen sifrenizi girin:");
while(flag = false){

    if (username === k_username && password == k_password) {
        console.log("Giris yapildi")
        flag = true;
    }
    else{
        console.log("Lutfen tekrar deneyiniz")
        flag = false;
    }
}
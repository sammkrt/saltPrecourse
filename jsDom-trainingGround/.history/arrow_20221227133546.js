var k_username ="guest";
var k_password = "12345";

var username = prompt("Lutfen Kullanici Adinizi Girin:");
var password = prompt("Lutfen sifrenizi girin:");
var Flag = false;


while(!Flag){
    if (username == k_username && password == k_password) {
        console.log("Giris yapildi")
        Flag = true;
    }
    else{
        console.log("Lutfen tekrar deneyiniz")
        Flag=false;
    }
}
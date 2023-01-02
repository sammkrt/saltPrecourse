function SayHello(name) {
    return `merhaba ${name}`;
}
const Sayhello2 = name =>`Merhaba ${name}`;

const topla = (a1,a2) => {
    return {
        IlkSayi: a1,
        IkinciSayi: a2,
        Toplam: a1 + a2
    }
}; 
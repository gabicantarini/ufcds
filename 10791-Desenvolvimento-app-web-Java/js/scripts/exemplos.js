var x = 1.5;
var y =2.0;

x=x*y;

x=(0.33333*3)*10/2

if (x<10)
document.write("X entre 0 e 10");

else if(x<20)
document.write("X entre 0 e 10");
else
document.write("outro<br>");


y="laranja"
document.write("<br><br>Exemplo 4 <br><br>");
if (y=="banana")
document.write("Muito bem");
else if(y=="laranja")
document.write("também é muito bom");
else if(y=="figo")
document.write("também é bom");
else
document.write("tem que comer fruta");
//console.log("O produto")

document.write("<br><br>Exemplo 5 <br>");

var a=0, b=0;
a=parseInt(prompt("de um valor: "));
b=parseInt(prompt("de outro valor: "));
c=a+b;
document.write("A soma é " + c);


document.write("<br><br>Exemplo 7 <br>");

var l=0;
while(l<10){
    l=l+1;
    if (l==3)
    continue; //break
    document.write(l + "<br>");
}


document.write("<br><br>Exemplo 8 <br>");

var r=0;
var valor = prompt("DE valor: ");
for (r=0.0; r*r<=valor;r=r+0.1)
{
    document.write(r.toFixed(1) + "<br>");
}
document.write("<br><br> A raiz quadrada é " + r.toFixed(1));

var x=0;

var aumento=10;

function inicializa()
{

	setInterval (function(){actualiza()},500);

}

function actualiza()
{

	x=x+aumento;

	document.getElementById("i1").style.left=x+"px";

    if(x>window.innerWidth - document.getElementById("i1").width)
    aumento =- aumento;

    if(x==0)
    aumento=-aumento;

}


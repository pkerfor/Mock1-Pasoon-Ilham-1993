function Beregning(): void{

    let BilensElement: HTMLInputElement=<HTMLInputElement>document.getElementById("BilPris");//her får jeg fat i det input element, hvor man skriver sin pris ind.
    let BilensPris: number = parseInt(BilensElement.value); //den her variable sætter jeg "ligemed" inputs element value som er prisen og som laver det om til int;.


    let BilTypeElement:HTMLSelectElement=<HTMLSelectElement>document.getElementById("BilTypeSelect"); //her får jeg fat i det select element som har valgt.
    let BilType: string = BilTypeElement.value; //den variable sætter jeg det "Ligemed" f.ks det som bliver valgt i selected Element.

    var result = AfgiftBeregning(BilType, BilensPris);

    let outputelement: HTMLOutputElement=<HTMLOutputElement>document.getElementById("output");
    outputelement.innerHTML="Afgiften er: " + result.toString();



}
function AfgiftBeregning(bilType:string, pris: number):number 
{
    switch(bilType)
    {
        case "Bil":
        {
            if (pris <= 200000)
            {
                let Bilafgift:number = pris*0.85;
                return Bilafgift;
            }
            else
            {
                let Bilafgift:number = (pris*1.5)-130000;
                return Bilafgift;
            }
        }
        case "Elbil":
        {
            if(pris <=200000)
            {
                let ElBilafgift:number = (pris*0.85)*0.20;
                return ElBilafgift;
            }
            else
            {
                let ElBilafgift:number= ((pris*1.5)-130000)*0.20;
                return ElBilafgift;
            }
        }

    }
}

let BeregnAfgift: HTMLButtonElement=<HTMLButtonElement>document.getElementById("BeregnAfgift");
BeregnAfgift.addEventListener("click", Beregning);
#pragma strict


var girarx : int = 0;
var girary : int = 0;
var girarz : int = 0;
var acumulador:int=0;
function Update () {
  
}
function OnMouseDown() {

         if(acumulador<180){
         transform.Rotate(girarx, girary, girarz+45);
           acumulador+=45;
         }else{
             
         }
  }
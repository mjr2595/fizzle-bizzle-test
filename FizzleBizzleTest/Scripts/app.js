var $Bazz = $("#Bazz");
var $Predicate = $("#Predicate");

function toggleBazz() {
    $Bazz.toggle();
    $Predicate.toggle();
}
 
$(window).on('load', function () {

    //toggle if Bazz field has a value 
    if (!($Bazz.val() == 0)) {
        toggleBazz()
    }

});
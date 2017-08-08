var $Bazz = $("#Bazz");
var $Predicate = $("#Predicate");

function toggleBazz() {
    $Bazz.toggle();
    $Predicate.toggle();
}


// on Window Load 
$(window).on('load', function () {

    //check if Bazz field has a value 
    if (!($Bazz.val() == 0)) {
        toggleBazz()
    }

});
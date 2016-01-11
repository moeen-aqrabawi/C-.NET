        $(function() {
            // create the image rotator
            setInterval("rotateImages()", 3000);
        });

function rotateImages() {
    var oCurPhoto = $('#hero div.current');
    var oNxtPhoto = oCurPhoto.next();
    if (oNxtPhoto.length == 0)
        oNxtPhoto = $('#hero div:first');

    oCurPhoto.removeClass('current').addClass('previous');
    oNxtPhoto.css({ opacity: 0.0 }).addClass('current')
            .animate({ opacity: 1.0 }, 1000,
                        function() {
                            oCurPhoto.removeClass('previous');
                        });
}

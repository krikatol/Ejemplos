function validate_fileupload(fileName) {
    if (fileName != null) {
        const allowed_extensions = new Array("csv");
        const file_extension = fileName.split('.').pop().toLowerCase();
        $('#subir').prop('disabled', true);
        // split function will split the filename by dot(.), and pop function will pop the last element from the array which will give you the extension as well. 
        // If there will be no extension then it will return the filename.

        for (let i = 0; i <= allowed_extensions.length; i++) {
            if (allowed_extensions[i] == file_extension) {
                $('#subir').removeAttr('disabled');
                return true; // valid file extension
            }
        }

        //return false;
        Swal.fire(
            '¡Comprueba tu archivo!',
            'Comprueba las extensiones permitidas o que el archivo no este dañado e intenta de nuevo...',
            'error'
        )
    }
}
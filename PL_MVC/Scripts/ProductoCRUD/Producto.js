$(document).ready(function () {
    GetAll();
});

function showForm() {

    $('#btnUpdate').hide();
    $('#btnAdd').show();

    $('#lblNombre').text('');
    $('#lblDescripcion').text('');
    $('#lblStock').text('');
    $('#lblPrecio').text('');
    $('#lblIdProveedor').text('');
    $('#lblIdDepartamento').text('');

    $('#lblNombre').hide();
    $('#lblDescripcion').hide();
    $('#lblStock').hide();
    $('#lblPrecio').hide();
    $('#lblIdProveedor').hide();
    $('#lblIdDepartamento').hide();

    $('#txtNombre').css('border-color', '');
    $('#txtDescripcion').css('border-color', '');
    $('#txtStock').css('border-color', '');
    $('#txtPrecioUnitario').css('border-color', '');
    $('#txtIdProveedor').css('border-color', '');
    $('#txtIdDepartamento').css('border-color', '');

    $('#txtIdProducto').val('');
    $('#txtNombre').val('');
    $('#txtDescripcion').val('');
    $('#txtStock').val('');
    $('#txtPrecioUnitario').val('');
    $('#txtIdProveedor').val('');
    $('#txtIdDepartamento').val('');

    $('#ModalUpdate').modal('show');
}

function LetrasNumeros(e,txtId,lblId) {

    tecla = (document.all) ? e.keyCode : e.which;

    var lbl = $('#' + lblId);
    var patron = /^[A-Za-z0-9-,/. ]*$/;

    tecla_final = String.fromCharCode(tecla);

    if (patron.test(tecla_final)) {
        $('#' + txtId).css("border-color", "#4BB543");
        lbl.hide();
    }
    else {
        $('#'+txtId).css("border-color", "#FF9494");
        lbl.text('No se admiten caracteres especiales');
        lbl.show();
    }

    return patron.test(tecla_final);
}

function SoloNumeros(e,txtId,lblId) {

    tecla = (document.all) ? e.keyCode : e.which;

    var lbl = $('#' + lblId);
    var patron = /^[0-9]*$/;

    tecla_final = String.fromCharCode(tecla);

    if (patron.test(tecla_final)) {
        $('#' + txtId).css("border-color", "#4BB543");
        lbl.hide();
    }
    else {
        $('#' + txtId).css("border-color", "#FF9494");
        $(lbl).text('Introducir solo numeros');
        lbl.show();
    }

    return patron.test(tecla_final);
}


function SoloDecimales(e, txtId, lblId) {

    tecla = (document.all) ? e.keyCode : e.which;

    var lbl = $('#' + lblId);
    var patron = /^[0-9.]*$/;

    tecla_final = String.fromCharCode(tecla);

    if (patron.test(tecla_final)) {
        $('#' + txtId).css("border-color", "#4BB543");
        lbl.hide();
    }
    else {
        $('#' + txtId).css("border-color", "#FF9494");
        lbl.text('Introducir solo numeros y decimales');
        lbl.show();
    }

    return patron.test(tecla_final);
}

function ValidarMinimo(txtId,lblId) {
    var valorMinimo = 1;
    var txt = $('#' + txtId);
    var lbl = $('#' + lblId);

    if (txt.val() < valorMinimo) {
        $('#' + txtId).css("border-color", "#FF9494");
        lbl.text('El valor minimo para este campo es: ' + valorMinimo);
        lbl.show();
    }
    else {
        lbl.hide();
    }

}

//$('#lblNombre').text('');
//$('#lblDescripcion').text('');
//$('#lblStock').text('');
//$('#lblPrecio').text('');
//$('#lblIdProveedor').text('');
//$('#lblIdDepartamento').text('');

//$('#lblNombre').hide();
//$('#lblDescripcion').hide();
//$('#lblStock').hide();
//$('#lblPrecio').hide();
//$('#lblIdProveedor').hide();
//$('#lblIdDepartamento').hide();

//$('#txtNombre').css('border-color', '');
//$('#txtDescripcion').css('border-color', '');
//$('#txtStock').css('border-color', '');
//$('#txtPrecio').css('border-color', '');
//$('#txtIdProveedor').css('border-color', '');
//$('#txtIdDepartamento').css('border-color', '');


function GetAll() {
    $.ajax({
        type: 'GET',
        url: 'https://localhost:44361/api/Producto/',
        success: function (result) { //200 OK 
             $('#producto tbody').empty();
            $.each(result.Objects, function (i, producto) {
                   var filas =
                       '<tr>'
                       + '<td class="text-center"> <button class="btn btn-info" onclick="GetById(' + producto.IdProducto + ')"><span class="glyphicon glyphicon-pencil" style="color:#FFFFFF"></span></button></td>'
                       + "<td  id='id' class='text-justified'>" + producto.Nombre + "</td>"
                       + "<td class='text-justified'>" + producto.Descripcion + "</td>"
                       + "<td class='text-justified'>$" + producto.PrecioUnitario + "</ td>"
                       + "<td class='text-justified'>" + producto.Stock + "</td>"
                       + "<td class='text-justified'>" + producto.Proveedor.Nombre + "</td>"
                       + "<td class='text-justified'>" + producto.Departamento.Nombre + "</td>"
                       //+ '<td class="text-center">  <a href="#" onclick="return Eliminar(' + subCategoria.IdSubCategoria + ')">' + '<img  style="height: 25px; width: 25px;" src="../img/delete.png" />' + '</a>    </td>'
                       + '<td class="text-center"> <button class="btn btn-danger" onclick="Eliminar(' + producto.IdProducto + ')"><span class="glyphicon glyphicon-trash" style="color:#FFFFFF"></span></button></td>'
                       + "</tr>";
                   $("#producto tbody").append(filas); 
            });
        },
        error: function (result) {
            alert('Error en la consulta.' + result.responseJSON.ErrorMessage);
        }
    });
};

function Eliminar(idProducto) {
    $.ajax({
        type: 'DELETE',
        url: 'https://localhost:44361/api/Producto/' + idProducto,
        datatype: 'JSON',
        success: function (result) {
            alert('Producto Eliminado ' + result.Correct);
            GetAll();
        },
        error: function (result) {
            alert('Ocurrio un error ' + result.ErrorMessage);
        }
    });
};



function GetById(idProducto) {
    $('#lblNombre').text('');
    $('#lblDescripcion').text('');
    $('#lblStock').text('');
    $('#lblPrecio').text('');
    $('#lblIdProveedor').text('');
    $('#lblIdDepartamento').text('');

    $('#lblNombre').hide();
    $('#lblDescripcion').hide();
    $('#lblStock').hide();
    $('#lblPrecio').hide();
    $('#lblIdProveedor').hide();
    $('#lblIdDepartamento').hide();

    $('#txtNombre').css('border-color', '');
    $('#txtDescripcion').css('border-color', '');
    $('#txtStock').css('border-color', '');
    $('#txtPrecioUnitario').css('border-color', '');
    $('#txtIdProveedor').css('border-color', '');
    $('#txtIdDepartamento').css('border-color', '');

    $.ajax({
        type: 'GET',
        url: 'https://localhost:44361/api/Producto/' + idProducto,
        success: function (result) {
            $('#txtIdProducto').val(result.Object.IdProducto);
            $('#txtNombre').val(result.Object.Nombre);
            $('#txtDescripcion').val(result.Object.Descripcion);
            $('#txtStock').val(result.Object.Stock);
            $('#txtPrecioUnitario').val(result.Object.PrecioUnitario);
            $('#txtIdProveedor').val(result.Object.Proveedor.IdProveedor);
            $('#txtIdDepartamento').val(result.Object.Departamento.IdDepartamento);

            $('#btnAdd').hide();
            $('#btnUpdate').show();

            $('#ModalUpdate').modal('show');
        },
        error: function (result) {
            alert('Ocurrio un error ' + result.ErrorMessage);
        }
    });
}


function Add() {
    var nombre = $('#txtNombre').val();
    var descripcion = $('#txtDescripcion').val();
    var stock = $('#txtStock').val();
    var precioUnitario = $('#txtPrecioUnitario').val();
    var idProveedor = $('#txtIdProveedor').val();
    var idDepartamento = $('#txtIdDepartamento').val();

    var producto = {
        Nombre: nombre,
        Descripcion: descripcion,
        Stock: stock,
        PrecioUnitario: precioUnitario,
        Proveedor: {
            IdProveedor: idProveedor
        },
        Departamento: {
            IdDepartamento: idDepartamento
        }
    };

    if (nombre == '' || descripcion == '' || stock == '' || precioUnitario == '' || idProveedor == '' || idDepartamento == '') {
        alert("Error al agregar. Ningún campo debe estar vacío");
    }
    else {
        $.ajax({
            type: 'POST',
            url: 'https://localhost:44361/api/Producto',
            data: producto,
            success: function (result) {
                alert('Producto agregado ' + result.Correct);
                GetAll();
                $('#ModalUpdate').modal('hide');
            },
            error: function (result) {
                alert('Ocurrio un error ' + result.ErrorMessage);
            }
        });
    }
   
}

function Update() {

    var idProducto = $('#txtIdProducto').val();
    var nombre = $('#txtNombre').val();
    var descripcion = $('#txtDescripcion').val();
    var stock = $('#txtStock').val();
    var precioUnitario = $('#txtPrecioUnitario').val();
    var idProveedor = $('#txtIdProveedor').val();
    var idDepartamento = $('#txtIdDepartamento').val();

    var producto = {
        IdProducto: idProducto,
        Nombre: nombre,
        Descripcion: descripcion,
        Stock: stock,
        PrecioUnitario: precioUnitario,
        Proveedor: {
            IdProveedor: idProveedor
        },
        Departamento: {
            IdDepartamento: idDepartamento
        }
    };

    if (nombre == '' || descripcion == '' || stock == '' || precioUnitario == '' || idProveedor == '' || idDepartamento == '') {
        alert("Error al agregar. Ningún campo debe estar vacío");
    }
    else {
        $.ajax({
            type: 'PUT',
            url: 'https://localhost:44361/api/Producto',
            data: producto,
            success: function (result) {
                alert('Producto actualizado ' + result.Correct);
                GetAll();
                $('#ModalUpdate').modal('hide');
            },
            error: function (result) {
                alert('Ocurrio un error ' + result.ErrorMessage);
            }
        });
    }

}



function LimpiarForm() {
    $('#nombreProducto').val('');
    $('#descripcionProducto').val('');
    $('#precioProducto').val('');
    $('#stockProducto').val('');
    $('#idproveedorProducto').val('');
    $('#iddepartamentoProducto').val('');
}
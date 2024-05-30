using System.Reflection.Emit;
@{
     ViewData["Title"] = "Alta de Empleados";
}

<form>
    <div class="mb-3">
        <label for="Nombre" class="form-label">Nombre</label>
        <input type="text" class="form-control" id="Nombre" name="precio" placeholder="Nombre del empleado">
        <label for="Role" class="form-label">Role</label>
        <input type="text" class="form-control" id="Role" name="role" placeholder="role">
    </div>
    <button type="submit" class="btn btn-primary"> Guardar</button>
    <button type="submit" class="btn btn-secundary"> Cancelar</button>
</form>
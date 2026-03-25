using FluentValidation;
using SeguimientoTramites.Features.Tramites.Dominio.Dto;

namespace SeguimientoTramites.Features.Tramites;

public class CrearTramiteValidator : AbstractValidator<CrearTramiteDTO>
{
    public CrearTramiteValidator()
    {
        RuleFor(x => x.Descrip)
            .NotEmpty().WithMessage("La descripción es requerida")
            .MaximumLength(100).WithMessage("La descripción no puede tener más de 100 cáracteres");
    }
}

public class ActualizarCarreraValidator : AbstractValidator<ActualizarTramiteDTO>
{
    public ActualizarCarreraValidator()
    {
        RuleFor(x => x.Descrip)
            .NotEmpty().WithMessage("La descripcion es requerida")
            .MaximumLength(100).WithMessage("La descripcion nno puede tener más de 100 cáracteres");
    }
}

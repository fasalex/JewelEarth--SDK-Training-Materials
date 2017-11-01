using JewelAddinTraining.Application.Api.Commands;
using Joa.JewelEarth.Basics.Drawing;
using Joa.JewelEarth.Infrastructure.CommandProcessing;
using Joa.JewelEarth.Mathematics.Geometry;
using Joa.JewelEarth.ReservoirBasicObjects.Enums;
using Joa.JewelEarth.Services;
using Joa.JewelEarth.Surfaces.Commands;
using Joa.JewelEarth.UnitSystem;

namespace JewelAddinTraining.Application.Logic.Handlers
{
    public class CreatePolylineSetCommandHandler : ICommandHandler<CreatePolylineSetCommand>
    {
        private readonly IFactoryService m_factoryService;

        public CreatePolylineSetCommandHandler(IFactoryService factoryService)
        {
            m_factoryService = factoryService;
        }
        public void Process(CreatePolylineSetCommand command)
        {
            // Get the services
            var createPolylineSetCommand = m_factoryService.Create<IPolylineSetCreateCommand>();

            // Setup the color, name and unitsystem settings for factory command
            var color = m_factoryService.Create<IColor>();
            color.SetRgba(0.56f, 0.0f, 0.0f, 0.56f);

            createPolylineSetCommand.Color = color;
            createPolylineSetCommand.Name = command.Name;
            createPolylineSetCommand.SetUnitSystem(UnitSystemDefinitionData.SI);
            createPolylineSetCommand.GeologicalType = GeologicalType.Horizon;

            // Insert the lines and the nodes of the polylineset into the factory command (world coordinates)
            createPolylineSetCommand.AddPolylineNode(0, 0, new Point3D(-400, 2382.15698242, 2764.31396484));
            createPolylineSetCommand.AddPolylineNode(0, 1, new Point3D(6300, 2421.05297852, 2842.10644531));

            createPolylineSetCommand.AddPolylineNode(1, 2, new Point3D(-400, -321.5878601069999, 3356.82421875));
            createPolylineSetCommand.AddPolylineNode(1, 3, new Point3D(6300, -255.5587310790002, 3488.88256836));

            createPolylineSetCommand.AddPolylineNode(2, 4, new Point3D(-400, 2582.15698242, 3164.31396484));
            createPolylineSetCommand.AddPolylineNode(2, 5, new Point3D(3764.82397461, 2119.40332031, 2238.80664063));
            createPolylineSetCommand.AddPolylineNode(2, 6, new Point3D(6300, 2621.05322266, 3242.10644531));

            createPolylineSetCommand.AddPolylineNode(3, 7, new Point3D(-400, 4642.67089844, 3426.3984375));
            createPolylineSetCommand.AddPolylineNode(3, 8, new Point3D(6300, 4600.42822266, 3200.85693359));

            createPolylineSetCommand.AddPolylineNode(4, 9, new Point3D(-400, -282.102905273, 3573.63476563));
            createPolylineSetCommand.AddPolylineNode(4, 10, new Point3D(6300, -155.5587615969998, 3688.88256836));

            createPolylineSetCommand.AddPolylineNode(5, 11, new Point3D(-420, -1214.27856445, 3773.31225586));
            createPolylineSetCommand.AddPolylineNode(5, 12, new Point3D(6310, -768.6317138670001, 3819.80712891));

            createPolylineSetCommand.AddPolylineNode(6, 13, new Point3D(-400, 4421.86230469, 2843.72412109));
            createPolylineSetCommand.AddPolylineNode(6, 14, new Point3D(6300, 4300.42871094, 2600.85693359));

            createPolylineSetCommand.AddPolylineNode(7, 15, new Point3D(-420, 6192.10400391, 3303.67333984));
            createPolylineSetCommand.AddPolylineNode(7, 16, new Point3D(6310, 6485.15234375, 2926.77612305));

            createPolylineSetCommand.Execute();
        }
    }
}

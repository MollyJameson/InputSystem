//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by DOTS Input Device Code Generator
//     version 1.1.0
//     from AndroidRelativeHumidity Layout
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Input;

#pragma warning disable CS0169

namespace Unity.Input
{
    public struct AndroidRelativeHumidityEvent : IInputData
    {
        public enum Id : uint
        {
            RelativeHumidity = 0,
        }

        public float RelativeHumidity;

        public uint Format => 1202796111;

        public DOTSInput.InputPipeline InputPipelineParts
        {
            get
            {
                var structMappings = new NativeArray<DOTSInput.InputStructMapping>(kStructMappingCount, Allocator.Persistent);
                var transforms = new NativeArray<DOTSInput.InputTransform>(kTransformCount, Allocator.Persistent);


                // AndroidRelativeHumidityEvent -> AndroidRelativeHumidityInput
                transforms[0] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.FloatToAxis),
                    InputId1 = (uint)Id.RelativeHumidity,
                    OutputId = (uint)AndroidRelativeHumidityInput.Id.RelativeHumidity
                };
                structMappings[0] = new DOTSInput.InputStructMapping
                {
                    InputFormat = 1202796111,
                    OutputFormat = 651214825,
                    InputSizeInBytes = (uint)UnsafeUtility.SizeOf<AndroidRelativeHumidityEvent>(),
                    OutputSizeInBytes = (uint)UnsafeUtility.SizeOf<AndroidRelativeHumidityInput>(),
                    TransformStartIndex = 0,
                    TransformCount = 1
                };

                // AndroidRelativeHumidityEvent -> HumiditySensorInput
                transforms[1] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.FloatToAxis),
                    InputId1 = (uint)Id.RelativeHumidity,
                    OutputId = (uint)HumiditySensorInput.Id.RelativeHumidity
                };
                structMappings[1] = new DOTSInput.InputStructMapping
                {
                    InputFormat = 1202796111,
                    OutputFormat = 2756787777,
                    InputSizeInBytes = (uint)UnsafeUtility.SizeOf<AndroidRelativeHumidityEvent>(),
                    OutputSizeInBytes = (uint)UnsafeUtility.SizeOf<HumiditySensorInput>(),
                    TransformStartIndex = 1,
                    TransformCount = 1
                };

                return new DOTSInput.InputPipeline
                {
                    StructMappings = structMappings,
                    Transforms = transforms,
                };
            }
        }

        private const int kStructMappingCount = 2;
        private const int kTransformCount = 2;
    }

    public struct AndroidRelativeHumidityInput : IComponentData, IInputData
    {
        public FloatInput RelativeHumidity;

        public enum Id : uint
        {
            RelativeHumidity = 0,
        }
        public uint Format => 651214825;

        public DOTSInput.InputPipeline InputPipelineParts
        {
            get
            {
                var structMappings = kStructMappingCount > 0 ? new NativeArray<DOTSInput.InputStructMapping>(kStructMappingCount, Allocator.Persistent) : default;
                var transforms = kTransformCount > 0 ? new NativeArray<DOTSInput.InputTransform>(kTransformCount, Allocator.Persistent) : default;

                return new DOTSInput.InputPipeline
                {
                    StructMappings = structMappings,
                    Transforms = transforms,
                };
            }
        }

        private const int kStructMappingCount = 0;
        private const int kTransformCount = 0;
    }
}
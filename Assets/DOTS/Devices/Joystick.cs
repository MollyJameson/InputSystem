//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by DOTS Input Device Code Generator
//     version 1.1.0
//     from Joystick Layout
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
    public struct JoystickEvent : IInputData
    {
        public enum Id : uint
        {
            Trigger = 4,
            StickX = 32,
            StickY = 64,
        }

        private int Padding0;
        public float StickX;
        public float StickY;

        public unsafe bool Trigger
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[0] & ((1 << 4) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[0] |= (1 << 4) & 0xFF;
                else
                    ((byte*)thisPtr)[0] &= ~(1 << 4) & 0xFF;
            }
        }

        public uint Format => 1624591240;

        public DOTSInput.InputPipeline InputPipelineParts
        {
            get
            {
                var structMappings = new NativeArray<DOTSInput.InputStructMapping>(kStructMappingCount, Allocator.Persistent);
                var transforms = new NativeArray<DOTSInput.InputTransform>(kTransformCount, Allocator.Persistent);


                // JoystickEvent -> JoystickInput
                transforms[0] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.Trigger,
                    OutputId = (uint)JoystickInput.Id.Trigger
                };
                transforms[1] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.FloatToAxis),
                    InputId1 = (uint)Id.StickX,
                    OutputId = (uint)JoystickInput.Id.StickX
                };
                transforms[2] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.FloatToAxis),
                    InputId1 = (uint)Id.StickY,
                    OutputId = (uint)JoystickInput.Id.StickY
                };
                structMappings[0] = new DOTSInput.InputStructMapping
                {
                    InputFormat = 1624591240,
                    OutputFormat = 28623406,
                    InputSizeInBytes = (uint)UnsafeUtility.SizeOf<JoystickEvent>(),
                    OutputSizeInBytes = (uint)UnsafeUtility.SizeOf<JoystickInput>(),
                    TransformStartIndex = 0,
                    TransformCount = 3
                };

                return new DOTSInput.InputPipeline
                {
                    StructMappings = structMappings,
                    Transforms = transforms,
                };
            }
        }

        private const int kStructMappingCount = 1;
        private const int kTransformCount = 3;
    }

    public struct JoystickInput : IComponentData, IInputData
    {
        public Float2Input Stick;
        public HalfAxisInput StickUp;
        public AxisInput StickX;
        public AxisInput StickY;
        public HalfAxisInput StickDown;
        public HalfAxisInput StickLeft;
        public HalfAxisInput StickRight;
        public ButtonInput Trigger;
        public ButtonInput ButtonStickUp;
        public ButtonInput ButtonStickDown;
        public ButtonInput ButtonStickLeft;
        public ButtonInput ButtonStickRight;

        public enum Id : uint
        {
            Stick = 0,
            StickUp = 64,
            StickX = 96,
            StickY = 128,
            StickDown = 160,
            StickLeft = 192,
            StickRight = 224,
            Trigger = 256,
            ButtonStickUp = 264,
            ButtonStickDown = 272,
            ButtonStickLeft = 280,
            ButtonStickRight = 288,
        }
        public uint Format => 28623406;

        public DOTSInput.InputPipeline InputPipelineParts
        {
            get
            {
                var structMappings = kStructMappingCount > 0 ? new NativeArray<DOTSInput.InputStructMapping>(kStructMappingCount, Allocator.Persistent) : default;
                var transforms = kTransformCount > 0 ? new NativeArray<DOTSInput.InputTransform>(kTransformCount, Allocator.Persistent) : default;

                transforms[0] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Combination.TwoAxesToOneFloat2),
                    InputId1 = (uint)Id.StickX,
                    InputId2 = (uint)Id.StickY,
                    OutputId = (uint)Id.Stick
                };
                transforms[1] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.PositiveAxisToHalfAxis),
                    InputId1 = (uint)Id.StickY,
                    OutputId = (uint)Id.StickUp
                };
                transforms[2] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.StickUp,
                    OutputId = (uint)Id.ButtonStickUp
                };
                transforms[3] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.NegativeAxisToHalfAxis),
                    InputId1 = (uint)Id.StickY,
                    OutputId = (uint)Id.StickDown
                };
                transforms[4] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.StickDown,
                    OutputId = (uint)Id.ButtonStickDown
                };
                transforms[5] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.NegativeAxisToHalfAxis),
                    InputId1 = (uint)Id.StickX,
                    OutputId = (uint)Id.StickLeft
                };
                transforms[6] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.StickLeft,
                    OutputId = (uint)Id.ButtonStickLeft
                };
                transforms[7] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.PositiveAxisToHalfAxis),
                    InputId1 = (uint)Id.StickX,
                    OutputId = (uint)Id.StickRight
                };
                transforms[8] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.StickRight,
                    OutputId = (uint)Id.ButtonStickRight
                };

                structMappings[0] = new DOTSInput.InputStructMapping
                {
                    InputFormat = 28623406,
                    OutputFormat = 28623406,
                    InputSizeInBytes = (uint)UnsafeUtility.SizeOf<JoystickInput>(),
                    OutputSizeInBytes = (uint)UnsafeUtility.SizeOf<JoystickInput>(),
                    TransformStartIndex = 0,
                    TransformCount = 9
                };
                return new DOTSInput.InputPipeline
                {
                    StructMappings = structMappings,
                    Transforms = transforms,
                };
            }
        }

        private const int kStructMappingCount = 1;
        private const int kTransformCount = 9;
    }
}
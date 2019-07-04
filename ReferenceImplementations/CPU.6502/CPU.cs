using System;
using System.Collections.Generic;

namespace CPU._6502
{
    public class CpuState
    {
        Dictionary<string, byte> Registers = new Dictionary<string, byte>();
        HashSet<ushort> Breakpoints = new HashSet<ushort>();
        ushort PC;
        ushort SP;
        byte[] RAM = new byte[4096];
        ulong CycleCount;
    }

    public class CPU
    {
        private CpuType _type;
        private CpuState _currentState = new CpuState();

        public CPU()
        {
            _type = CpuType.Generic6502;
        }

        public CPU(CpuType type)
        {
            _type = type;
        }

        public void Continue()
        {

        }

        public void Pause()
        {
            // Pause execution
        }

        public void UpdatePC(ushort address)
        {

        }

        public void ToggleBreakpoint(ushort address)
        {

        }

        public void Step()
        {
            // Increment one instruction, turn off Running mode and go into step mode if 
        }

        public void IsRunning()
        {

        }

        public CpuState GetState()
        {
            return _currentState;
        }
    }
}

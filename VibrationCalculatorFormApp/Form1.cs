using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VibroMath; 
public enum TextboxIsChangeable {
    Acceleration,
    Acceleration_dB,
    Velocity,
    Velocity_dB,
    Displacement,
    Displacement_dB,
    Voltage,
    Voltage_dB,
    Sensitivity,
    Frequency,
    NotTextbox
}
namespace VibrationCalculatorFormApp {
    public partial class Form1 : Form {
        SignalParametrType AccType = SignalParametrType.RMS;
        SignalParametrType VelType = SignalParametrType.RMS;
        SignalParametrType DisType = SignalParametrType.RMS;
        SignalParametrType VoltType = SignalParametrType.RMS;
        SensitivityType SenType = SensitivityType.mV_G;
        FrequencyType FreqType = FrequencyType.HZ;
        Freeze Freeze = Freeze.Acceleration;

        

        public Form1() {
            InitializeComponent();
            PushAllTextboxes(TextboxIsChangeable.NotTextbox);
        }

        private void TSensitivity_KeyPress(object sender, KeyPressEventArgs e) {
           
        }

        private void TSensitivity_TextChanged(object sender, EventArgs e) {
            if (double.TryParse(TSensitivity.Text, out double result)) {
                VibroCalc.CalcAll(new Sensitivity(result, SenType), Freeze);
            }
            PushAllTextboxes(TextboxIsChangeable.Sensitivity);
        }

        private void TFrequency_TextChanged(object sender, EventArgs e) {
            if (double.TryParse(TFrequency.Text, out double result)) {
                VibroCalc.CalcAll(new Frequency(result, FreqType), Freeze);
            }
            PushAllTextboxes(TextboxIsChangeable.Frequency);
        }

        private void TAcceleration_TextChanged(object sender, EventArgs e) {
            if (double.TryParse(TAcceleration.Text, out double result)) {
                VibroCalc.CalcAll(new Acceleration(result, AccType));
            }
            PushAllTextboxes(TextboxIsChangeable.Acceleration);
        }

        private void radAccelerationRMS_CheckedChanged(object sender, EventArgs e) {
            /// Добавил рассказать
            if (radAccelerationRMS.Checked) {
                AccType = SignalParametrType.RMS;
            }
            PushAllTextboxes(TextboxIsChangeable.NotTextbox);
            /// Добавить push textboxes
        }
        private void PushAllTextboxes(TextboxIsChangeable isChangeable) {
            if (isChangeable != TextboxIsChangeable.Sensitivity) {
                TSensitivity.Access = Access.Blocked;
                TSensitivity.Text = VibroCalc.Sensitivity.Get(SenType).ToString();
                TSensitivity.Access = Access.UnLock;
            }
            if (isChangeable != TextboxIsChangeable.Frequency) {
                TFrequency.Access = Access.Blocked;
                TFrequency.Text = VibroCalc.Frequency.Get(FreqType).ToString();
                TFrequency.Access = Access.UnLock;
            }
            if (isChangeable != TextboxIsChangeable.Voltage) {
                TVoltage.Access = Access.Blocked;
                TVoltage.Text = VibroCalc.Voltage.Get(VoltType).ToString();
                TVoltage.Access = Access.UnLock;
            }
            if (isChangeable != TextboxIsChangeable.Voltage_dB) {
                TVoltage_dB.Access = Access.Blocked;
                TVoltage_dB.Text = VibroCalc.Voltage.Get(SignalParametrType.dB).ToString();
                TVoltage_dB.Access = Access.UnLock;
            }
            if (isChangeable != TextboxIsChangeable.Acceleration) {
                TAcceleration.Access = Access.Blocked;
                TAcceleration.Text = VibroCalc.Acceleration.Get(AccType).ToString();
                TAcceleration.Access = Access.UnLock;
            }
            if (isChangeable != TextboxIsChangeable.Acceleration_dB) {
                TAcceleration_dB.Access = Access.Blocked;
                TAcceleration_dB.Text = VibroCalc.Acceleration.Get(SignalParametrType.dB).ToString();
                TAcceleration_dB.Access = Access.UnLock;
            }
           
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void radVoltageRMS_CheckedChanged(object sender, EventArgs e) {
            if (radVoltageRMS.Checked) {
                VoltType = SignalParametrType.RMS;
            }
            PushAllTextboxes(TextboxIsChangeable.NotTextbox);
        }

        private void radSensitivityG_CheckedChanged(object sender, EventArgs e) {
            if (radSensitivityG.Checked) {
                SenType = SensitivityType.mV_G;
            }
            PushAllTextboxes(TextboxIsChangeable.NotTextbox);
        }

        private void radSensitivityM_CheckedChanged(object sender, EventArgs e) {
            if (radSensitivityM.Checked) {
                SenType = SensitivityType.mV_MS2;
            }
            PushAllTextboxes(TextboxIsChangeable.NotTextbox);
        }

        private void radFrequencyHw_CheckedChanged(object sender, EventArgs e) {
            if (radFrequencyHw.Checked) {
                FreqType = FrequencyType.HZ;
            }
            PushAllTextboxes(TextboxIsChangeable.NotTextbox);
        }

        private void radFrequencyRPM_CheckedChanged(object sender, EventArgs e) {
            if (radFrequencyRPM.Checked) {
                FreqType = FrequencyType.HZ;
            }
            PushAllTextboxes(TextboxIsChangeable.NotTextbox);
        }

        private void radVoltagePik_CheckedChanged(object sender, EventArgs e) {
            if (radVoltagePik.Checked) {
                VoltType = SignalParametrType.PIK;
            }
            PushAllTextboxes(TextboxIsChangeable.NotTextbox);
        }
        private void radVoltagePikPik_CheckedChanged(object sender, EventArgs e) {
            if (radVoltagePikPik.Checked) {
                VoltType = SignalParametrType.PIK_PIK;
            }
            PushAllTextboxes(TextboxIsChangeable.NotTextbox);
        }
        private void radAccelerationPik_CheckedChanged(object sender, EventArgs e) {
            if (radAccelerationPik.Checked) {
                AccType = SignalParametrType.PIK;
            }
            PushAllTextboxes(TextboxIsChangeable.NotTextbox);
        }
        private void radAccelerationPikPik_CheckedChanged(object sender, EventArgs e) {
            if (radAccelerationPikPik.Checked) {
                AccType = SignalParametrType.PIK_PIK;
            }
            PushAllTextboxes(TextboxIsChangeable.NotTextbox);
        }

        private void radVelocityRMS_CheckedChanged(object sender, EventArgs e) {
            if (radVelocityRMS.Checked) {
                VelType = SignalParametrType.RMS;
            }
            PushAllTextboxes(TextboxIsChangeable.NotTextbox);
        }

        private void radVelocityPik_CheckedChanged(object sender, EventArgs e) {
            if (radVelocityPik.Checked) {
                VelType = SignalParametrType.PIK;
            }
            PushAllTextboxes(TextboxIsChangeable.NotTextbox);
        }

        private void radVelocityPikPik_CheckedChanged(object sender, EventArgs e) {
            if (radVelocityPikPik.Checked) {
                VelType = SignalParametrType.PIK_PIK;
            }
            PushAllTextboxes(TextboxIsChangeable.NotTextbox);
        }

        private void radDisplacementRMS_CheckedChanged(object sender, EventArgs e) {
            if (radDisplacementRMS.Checked) {
                DisType = SignalParametrType.RMS;
            }
            PushAllTextboxes(TextboxIsChangeable.NotTextbox);
        }

        private void radDisplacementPik_CheckedChanged(object sender, EventArgs e) {
            if (radDisplacementPik.Checked) {
                DisType = SignalParametrType.PIK;
            }
            PushAllTextboxes(TextboxIsChangeable.NotTextbox);
        }

        private void radiDisplacementPikPik_CheckedChanged(object sender, EventArgs e) {
            if (radiDisplacementPikPik.Checked) {
                DisType = SignalParametrType.PIK_PIK;
            }
            PushAllTextboxes(TextboxIsChangeable.NotTextbox);
        }

        private void radVoltSensFreq_CheckedChanged(object sender, EventArgs e) {
            if (radVoltSensFreq.Checked) {
                Freeze = Freeze.Voltage;
            }
        }

        private void radAccSensFreq_CheckedChanged(object sender, EventArgs e) {
            if (radAccSensFreq.Checked) {
                Freeze = Freeze.Acceleration;
            }
        }

        private void radVelSensFreq_CheckedChanged(object sender, EventArgs e) {
            if (radAccSensFreq.Checked) {
                Freeze = Freeze.Velocity;
            }
        }

        private void radDispSensFreq_CheckedChanged(object sender, EventArgs e) {
            if (radAccSensFreq.Checked) {
                Freeze = Freeze.Displacement;
            }
        }

        private void TVoltage_TextChanged(object sender, EventArgs e) {
            if (double.TryParse(TVoltage.Text, out double result)) {
                VibroCalc.CalcAll(new Voltage(result, VoltType));
            }
            PushAllTextboxes(TextboxIsChangeable.Voltage);
        }

        private void TVoltage_dB_TextChanged(object sender, EventArgs e) {
            if (double.TryParse(TVoltage_dB.Text, out double result)) {
                VibroCalc.CalcAll(new Voltage(result, SignalParametrType.dB));
            }
            PushAllTextboxes(TextboxIsChangeable.Voltage_dB);
        }

        private void TAcceleration_dB_TextChanged(object sender, EventArgs e) {
            if (double.TryParse(TAcceleration_dB.Text, out double result)) {
                VibroCalc.CalcAll(new Acceleration(result, SignalParametrType.dB));
            }
            PushAllTextboxes(TextboxIsChangeable.Acceleration_dB);
        }
    }
}

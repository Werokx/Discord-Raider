using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundBtn : Button
{
  private Color _borderColor = Color.Silver;
  private Color _onHoverBorderColor = Color.Gray;
  private Color _buttonColor = Color.Red;
  private Color _onHoverButtonColor = Color.Yellow;
  private Color _textColor = Color.White;
  private Color _onHoverTextColor = Color.Gray;
  private bool _isHovering;
  private int _borderThickness = 6;
  private int _borderThicknessByTwo = 3;

  public RoundBtn()
  {
    this.DoubleBuffered = true;
    this.MouseEnter += (EventHandler)((sender, e) =>
    {
      this._isHovering = true;
      this.Invalidate();
    });
    this.MouseLeave += (EventHandler)((sender, e) =>
    {
      this._isHovering = false;
      this.Invalidate();
    });
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    base.OnPaint(e);
    Graphics graphics = e.Graphics;
    graphics.SmoothingMode = SmoothingMode.AntiAlias;
    Brush brush1 = (Brush)new SolidBrush(this._isHovering ? this._onHoverBorderColor : this._borderColor);
    graphics.FillEllipse(brush1, 0, 0, this.Height, this.Height);
    graphics.FillEllipse(brush1, this.Width - this.Height, 0, this.Height, this.Height);
    graphics.FillRectangle(brush1, this.Height / 2, 0, this.Width - this.Height, this.Height);
    brush1.Dispose();
    Brush brush2 = (Brush)new SolidBrush(this._isHovering ? this._onHoverButtonColor : this._buttonColor);
    graphics.FillEllipse(brush2, this._borderThicknessByTwo, this._borderThicknessByTwo, this.Height - this._borderThickness, this.Height - this._borderThickness);
    graphics.FillEllipse(brush2, this.Width - this.Height + this._borderThicknessByTwo, this._borderThicknessByTwo, this.Height - this._borderThickness, this.Height - this._borderThickness);
    graphics.FillRectangle(brush2, this.Height / 2 + this._borderThicknessByTwo, this._borderThicknessByTwo, this.Width - this.Height - this._borderThickness, this.Height - this._borderThickness);
    brush2.Dispose();
    Brush brush3 = (Brush)new SolidBrush(this._isHovering ? this._onHoverTextColor : this._textColor);
    SizeF sizeF = graphics.MeasureString(this.Text, this.Font);
    graphics.DrawString(this.Text, this.Font, brush3, (float)(((double)this.Width - (double)sizeF.Width) / 2.0), (float)(((double)this.Height - (double)sizeF.Height) / 2.0));
  }

  public Color BorderColor
  {
    get => this._borderColor;
    set
    {
      this._borderColor = value;
      this.Invalidate();
    }
  }

  public Color OnHoverBorderColor
  {
    get => this._onHoverBorderColor;
    set
    {
      this._onHoverBorderColor = value;
      this.Invalidate();
    }
  }

  public Color ButtonColor
  {
    get => this._buttonColor;
    set
    {
      this._buttonColor = value;
      this.Invalidate();
    }
  }

  public Color OnHoverButtonColor
  {
    get => this._onHoverButtonColor;
    set
    {
      this._onHoverButtonColor = value;
      this.Invalidate();
    }
  }

  public Color TextColor
  {
    get => this._textColor;
    set
    {
      this._textColor = value;
      this.Invalidate();
    }
  }

  public Color OnHoverTextColor
  {
    get => this._onHoverTextColor;
    set
    {
      this._onHoverTextColor = value;
      this.Invalidate();
    }
  }
}

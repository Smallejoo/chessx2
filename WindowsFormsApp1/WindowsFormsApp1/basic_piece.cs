using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Properties
{
    public abstract class basic_piece
    {
        
        public enum ChessColor { black, white, blank}
        public enum ChessMoveColor { green,attack,none}
        public virtual string who_am_i()
        {
            return "E";
        }
        public virtual void leagel_moves(basic_piece the_one,board current_board)
        {
           


            
        }
       
        public virtual void move_piece(basic_piece from , basic_piece to_where)
        {
            
        }
        public ChessColor color { set; get; }
        public ChessMoveColor Mcolor { set; get; }

        public Cordinates position { set; get; }
        public basic_piece(ChessColor its_color, Cordinates its_position)
        {
            this.color = its_color;
            this.position = its_position;
            this.Mcolor = basic_piece.ChessMoveColor.none;


        }
        public int Storage { set; get; }


    }
}

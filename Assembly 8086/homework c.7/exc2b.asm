.MODEL small
.STACK 100h
.DATA
  Array db 0FAh, 02Eh, 03Bh, 0AAh, 0FFh, 06Bh
.CODE
  mov ax, @data
  mov ds, ax
  
  xor ax, ax
  xor bx, bx
  
  mov bl, [Array]
  add ax, bx
  mov bl, [Array+1]
  add ax, bx
  mov bl, [Array+2]
  add ax, bx
  mov bl, [Array+3]
  add ax, bx
  mov bl, [Array+4]
  add ax, bx
  mov bl, [Array+5]
  add ax, bx
END


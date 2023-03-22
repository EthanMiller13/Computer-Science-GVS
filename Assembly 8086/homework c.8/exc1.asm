.MODEL small
.STACK 100h
.DATA

.CODE
   mov ax, 09h
   ;mov ax, 0
   
   cmp ax, 0
   jg ax_is_greater
   
   jmp exit
   
ax_is_greater:
   dec ax

exit:
    mov ah, 4Ch
    int 21h
END